using Barcoder;
using Barcoder.Code128;
using Barcoder.Qr;
using System;
using System.Drawing;
using System.Windows.Forms;
using Encoding = Barcoder.Qr.Encoding;

// Traceability demo program. Extended GTIN, date, and lot number encoded into an rfid string.
// John Gallant, contracting for Avery Dennison
// Uses a barcode graphics library from GitHub.
// Assumes an rfid chip with (at least) a 128-bit EPC memory.

namespace Barcode006
{
    public partial class FmCGTIN : Form
    {
        Color backColor;
        Color backColorRO;    // read only windows
        Color foreColor;
        int idxHeader = 0;
        int idxGTIN = 0;
        int idxDateType = 3;
        int idxDate = 0;
        int idxLot = 0;
        int idxSer = 0;
        bool loading = false;
        long lgtin = 0;
        int bDecoding = 0;

        private void FmCGTIN_Load(object sender, EventArgs e)
        {
            loading = true;
            txError.Text = "--";
            txWarn.Text = "--";
            cxHeader.SelectedIndex = idxHeader;
            CheckHeader();
            cxDateType.SelectedIndex = idxDateType;
            CheckDateType();
            cxDate.SelectedIndex = idxDate;
            CheckDate();
            cxGTIN.SelectedIndex = idxGTIN;
            CheckGTIN();
            CvtGTIN();
            cxLotNum.SelectedIndex = idxLot;
            CheckLot();
            cxSerNum.SelectedIndex = idxSer;
            backColor = cxGTIN.BackColor;
            backColorRO = cxEPC.BackColor;
            foreColor = cxGTIN.ForeColor;
            loading = false;
            loading = false;
        }

        int Recalc()
        {
            //int ret;

            ClearErrors();
            //ret = RecalcEPC();
            //if (ret != 0)
            //    return ret;
            return 0;
        }

        public void ClearErrors()
        {
            bool wasloading = false;

            if (!loading)
            {
                wasloading = false;
                loading = true;
            }
            cxHeader.BackColor = backColor;
            cxHeader.ForeColor = foreColor;
            cxGTIN.BackColor = backColor;
            cxGTIN.ForeColor = foreColor;
            cxDateType.BackColor = backColorRO;
            cxDate.BackColor = backColor;
            cxDate.ForeColor = foreColor;
            cxLotNum.BackColor = backColor;
            cxLotNum.ForeColor = foreColor;
            cxEPC.BackColor = backColor;
            cxEPC.ForeColor = foreColor;
            txError.BackColor = backColorRO;
            txError.ForeColor = foreColor;
            txError.Text = "";
            txWarn.BackColor = backColorRO;
            txWarn.ForeColor = foreColor;
            txWarn.Text = "";
            if (!wasloading)
                loading = false;
        }

        public FmCGTIN()
        {
            InitializeComponent();
        }

        public FmCGTIN(string strTextBox)
        {
            InitializeComponent();
        }

        void PostErrorMsg(string msg)
        {
            txError.Text = msg;
            txError.BackColor = Color.Red;
        }

        void PostWarnMsg(string msg)
        {
            txWarn.Text = msg;
            txWarn.BackColor = Color.Yellow;
        }

        int CheckHeader()
            // Eight bits are reserved for an identifying header
        {
            String str, str2;
            int c0, c1;

            str = cxHeader.Text;
            str2 = "";
            if (str.Length != 2)
            {
                cxHeader.BackColor = Color.Red;
                PostErrorMsg("Invalid header. Needs 2 hex digits.");
                return (-1);
            }
            c0 = str[0];
            c1 = str[1];
            if ((c0 >= 'a') && (c0 <= 'f'))
                c0 = char.ToUpper((char)c0);
            if ((c1 >= 'a') && (c1 <= 'f'))
                c1 = char.ToUpper((char)c1);
            if (((c0 >= '0') && (c0 <= '9'))
                    || ((c0 >= 'A') && (c0 <= 'F')))
            {
                str2 = str2 + (char)c0;
                if (((c1 >= '0') && (c1 <= '9'))
                        || ((c1 >= 'A') && (c1 <= 'F')))
                {
                    str2 = str2 + (char)c1;
                    laHeaderHex.Text = str2;
                    laHeaderShift.Text = str2;
                    return 0;
                }
            }
            cxHeader.BackColor = Color.Red;
            PostErrorMsg("Invalid header. Needs 2 hex digits.");
            return (-2);
        }

        long CheckGTIN()
        // Check the GTIN format, including check digit
        {
            String str;

            str = cxGTIN.Text;
            if (str.Length == 13)
            {
                str = str + genChkDigit(str).ToString();
            }
            else if (str.Length != 14)
            {
                cxGTIN.BackColor = Color.Red;
                PostErrorMsg("GTIN must be 14 digits, including checkdigit.");
                lgtin = 0;
                return (-1);
            }
            //str = str.Substring(0, 13);    // drop check digit if present
            bool success = Int64.TryParse(str, out long mylgtin);
            if (success)
            {
                if (mylgtin < 0)
                {
                    cxGTIN.BackColor = Color.Red;
                    PostErrorMsg("GTIN must be 14 digits, including checkdigit.");
                    lgtin = 0;
                    return -2;
                }
                else
                {
                    lgtin = mylgtin;
                    return lgtin;
                }
            }
            else
            {
                cxGTIN.ForeColor = Color.Red;
                PostErrorMsg("GTIN must be 14 digits, with checksum.");
                lgtin = 0;
                return (-4);
            }
        }

        int genChkDigit(String instr)
        // Returns check digit for input string
        // The final digit of a Universal Product Code is a check digit computed as follows:
        // Add the digits in the odd-numbered positions from the right(first, third, fifth, etc.
        //   -not including the check digit) together and multiply by three.
        // Add the digits(up to but not including the check digit) in the even-numbered
        //   positions(second, fourth, sixth, etc.) to the result.
        // Take the remainder of the result divided by 10(modulo operation).
        //   If the remainder is equal to 0 then use 0 as the check digit,
        //   and if not 0 subtract the remainder from 10 to derive the check digit.
        {
            int sumOdd = 0;
            int sumEven = 0;
            int sum = 0;
            int chkDigIn = -1;
            int chkDigCalc = 0;

            if (instr.Length == 14)
            {
                chkDigIn = instr[13] - '0';
                instr = instr.Substring(0, 13);    // Strip off input chk digit
            }
            if (instr.Length != 13)    // Check for valid length
                return -1;
            for (int i = 0; i < 7; i++)
            {
                sumOdd += instr[2 * i] - '0';
            }
            for (int i = 0; i < 6; i++)
            {
                sumEven += instr[(2 * i) + 1] - '0';
            }
            chkDigCalc = ((3 * sumOdd) + sumEven) % 10;
            if (chkDigCalc > 0)
            {
                chkDigCalc = 10 - chkDigCalc;
            }
            if (bDecoding == 0)    // If not decoding
            {
                if (chkDigCalc != chkDigIn)
                    PostWarnMsg("Check digit should be " + chkDigCalc.ToString());
            }
            else
            {
                cxGTIN.Text = instr + chkDigCalc.ToString();
            }
            return sum;
        }

        void CvtGTIN()
        // Encode the GTIN, including check digit, in straight binary
        {
            String szeroes = "000000000000";
            String sgtin = lgtin.ToString("X");
            laGTINHex.Text = szeroes.Substring(0, 12 - sgtin.Length) + sgtin;
            sgtin = (0x4 * lgtin).ToString("X");    // Shift left 2 bits
            laGTINShift.Text = szeroes.Substring(0, 12 - sgtin.Length) + sgtin;
        }

        void CheckDateType()
        // Get date type index from table
        {
            laDateTypeHex.Text = cxDateType.SelectedIndex.ToString("X");
            laDateTypeShift.Text = laDateTypeHex.Text;
        }

        long CheckDate()
        // Check the date format. The decial value displayed in the combo box is YMMDD.
        // This is converted to binary as follows:
        //     4 bits for last digit of year
        //     4 bits for month
        //     5 bits for day of month
        {
            String szeroes = "0000";
            String sdate = cxDate.Text;
            int result;
            if (int.TryParse(sdate, out result))
            {
                if (sdate.Length == 5)
                {
                    int iyear = Convert.ToInt32(sdate.Substring(0, 1), 10);
                    int imonth = Convert.ToInt32(sdate.Substring(1, 2), 10);
                    if ((imonth < 1) || (imonth > 12))
                    {
                        cxDate.ForeColor = Color.Red;
                        PostErrorMsg("Invalid date format. (YMMDD, Month 1..12)");
                        return -2;
                    }
                    int iday = Convert.ToInt32(sdate.Substring(3, 2), 10);
                    switch (imonth)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if ((iday < 1) || (iday > 31))
                            {
                                cxDate.ForeColor = Color.Red;
                                PostErrorMsg("Invalid date format. (YMMDD, Day 1..31)");
                                return -2;
                            }
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if ((iday < 1) || (iday > 30))
                            {
                                cxDate.ForeColor = Color.Red;
                                PostErrorMsg("Invalid date format. (YMMDD, Day 1..30)");
                                return -2;
                            }
                            break;
                        case 2:
                            if ((iday < 1) || (iday > 29))
                            {
                                cxDate.ForeColor = Color.Red;
                                PostErrorMsg("Invalid date format. (YMMDD, Day 1..29)");
                                return -2;
                            }
                            break;
                        default:
                            cxDate.ForeColor = Color.Red;
                            PostErrorMsg("Invalid date format. (YMMDD)");    // Should never get here
                            return -2;
                    }
                    int ipackeddate = 0x200 * iyear + 0x20 * imonth + iday;
                    String sDateX = ipackeddate.ToString("X");
                    laDateValueHex.Text = szeroes.Substring(0, 4 - sDateX.Length) + sDateX;
                    ipackeddate *= 0x8;    // Shift left 3 bits
                    sDateX = ipackeddate.ToString("X");
                    laDateValueShift.Text = szeroes.Substring(0, 4 - sDateX.Length) + sDateX;
                }
                else
                {
                    cxDate.ForeColor = Color.Red;
                    PostErrorMsg("Invalid date format. (YMMDD)");
                    return -2;
                }
            }
            else
            {
                cxDate.ForeColor = Color.Red;
                PostErrorMsg("Invalid date format. (YMMDD, all numbers)");
                return -2;
            }
            return 0;
        }

        int DecodeDate(int date)
        // See above for encoding scheme
        {
            int year, month, day;
            String sdate = cxDate.Text;
            String str;

            year = date / 0x200;
            month = (date & 0x1E0) / 0x20;
            day = date & 0x1F;
            // check values
            if (year > 9)
            {
                cxEPC.ForeColor = Color.Red;
                PostErrorMsg("Invalid year format. (YMMDD, Year 0..9)");
                return -1;
            }
            str = year.ToString();
            if ((month < 1) || (month > 12))
            {
                cxEPC.ForeColor = Color.Red;
                PostErrorMsg("Invalid month format. (YMMDD, Month 1..12)");
                return -2;
            }
            if (month > 9)
            {
                str = str + month.ToString();
            }
            else
            {
                str = str + "0" + month.ToString();
            }
            if ((day < 1) || (day > 31))
            {
                cxEPC.ForeColor = Color.Red;
                PostErrorMsg("Invalid day format. (YMMDD, Day 1..31)");
                return -2;
            }
            if (day > 9)
            {
                str = str + day.ToString();
            }
            else
            {
                str = str + "0" + day.ToString();
            }
            cxDate.Text = str;
            return 0;
        }

        // Lot number encoding/decoding
        // The (up to) 11-character upper-case alphanumeric lot number is encoded in 
        // radix-40 from the following table. The encoding is in triplets, starting
        // from the right. The first two characters (from left) are encoded together.
        //
        // Table 1 – Radix-40 Character Set
        // Symbol Name              ASCII hex   Binary      Code
        //  PAD   						0 
        //  A   Capital letter A		41   	01000001	1 
        //  B   Capital letter B  		42 	    01000010  	2 
        //  C   Capital letter C  		43 	    01000011  	3 
        //  D   Capital letter D      	44      01000100  	4 
        //  E   Capital letter E  		45      01000101  	5 
        //  F   Capital letter F  		46      01000110  	6 
        //  G   Capital letter G      	47      01000111  	7 
        //  H   Capital letter H      	48      01001000  	8 
        //  I   Capital letter I  		49      01001001  	9 
        //  J   Capital letter J  		4A      01001010  	10 
        //  K   Capital letter K  		4B      01001011  	11 
        //  L   Capital letter L  		4C  	01001100  	12 
        //  M   Capital letter M      	4D  	01001101  	13 
        //  N   Capital letter N      	4E  	01001110  	14 
        //  O   Capital letter O      	4F  	01001111  	15 
        //  P   Capital letter P 		50  	01010000  	16 
        //  Q   Capital letter Q     	51  	01010001  	17 
        //  R   Capital letter R  		52  	01010010  	18 
        //  S   Capital letter S  		53  	01010011  	19 
        //  T   Capital letter T 		54  	01010100  	20 
        //  U   Capital letter U     	55  	01010101  	21 
        //  V   Capital letter V  		56  	01010110  	22 
        //  W   Capital letter W     	57  	01010111  	23 
        //  X   Capital letter X  		58  	01011000  	24 
        //  Y   Capital letter Y  		59  	01011001  	25 
        //  Z   Capital letter Z  		5A  	01011011 	26 
        //  – 	Hyphen-Minus     		2D  	00101101  	27 
        //  .   Full stop       		2E  	00101110 	28 
        //  : 	Colon        			3A	    00101110 	29 
        //  0 	Digit zero          	30  	00110000  	30 
        //  1 	Digit one         		31  	00110001  	31 
        //  2 	Digit two         		32  	00110010  	32 
        //  3 	Digit three     		33      00110011  	33 
        //  4 	Digit four       		34  	00110100  	34 
        //  5 	Digit five       		35  	00110101  	35 
        //  6 	Digit six           	36  	00110110  	36 
        //  7 	Digit seven     		37  	00110111  	37 
        //  8 	Digit eight     		38  	00111000  	38 
        //  9 	Digit nine       		39  	00111001  	39 
        //

        int R40Encode(char c)
        // Returns the index of c in radix-40 table
        {
            if (c == ' ')    // Pad character. Actually, should be a null.
                return 0;
            else if ((c >= 'A') && (c <= 'Z'))
                return 1 + c - 'A';
            else if (c == '-')
                return 27;
            else if (c == '.')
                return 28;
            else if (c == ':')
                return 29;
            else if ((c >= '0') && (c <= '9'))
                return 30 + c - '0';
            else
                return -1;    // Should be unreachable
        }

        char? R40Decode(int idx)
        // Returns the character associated with the index idx in radix-40 table
        {
            if (idx == 0)
                return null;
            else if ((idx >= 1) && (idx <= 26))
                return (char)('A' + (idx - 1));
            else if (idx == 27)
                return '-';
            else if (idx == 28)
                return '.';
            else if (idx == 29)
                return ':';
            else if ((idx >= 30) && (idx <= 39))
                return (char)('0' + (idx - 30));
            else
            {
                PostErrorMsg("Internal decoder error.");
                return '!';
            }
        }

        long CheckLot()
        {
            String str;
            String spad = "           ";
            String szeroes = "0000";

            str = cxLotNum.Text;
            int len = str.Length;
            if (len > 11)
            {
                cxLotNum.BackColor = Color.Red;
                PostErrorMsg("Max 11 characters. (0-9, A-Z, '-', '.', ':', ' ')");
                return (-1);
            }
            if (len < 11)
                str = str + spad.Substring(0, 11 - len);    // Pad on right with spaces
            for (int i = 0; i < len; i++)
            {
                char c = str[i];
                // Test to see if character valid
                if (((c >= 'A') && (c <= 'Z'))
                    || ((c >= '0') && (c <= '9'))
                    || (c == '-') || (c == '.') || (c == ':') || (c == ' '))
                {
                    continue;
                }
                else
                {
                    cxLotNum.BackColor = Color.Red;
                    PostErrorMsg("Invalid lot character. (0-9, A-Z, '-', '.', ':', ' ')");
                    return -2;
                }
            }
            // Characters are encoded in blocks of three using base (radix) 40.
            // The first group contains only 2 characters.
            String s0, s1, s2, s3;
            int i0, i1, i2, i3;
            i0 = 40 * R40Encode(str[0]) + R40Encode(str[1]);
            i1 = 1600 * R40Encode(str[2]) + 40 * R40Encode(str[3]) + R40Encode(str[4]);
            i2 = 1600 * R40Encode(str[5]) + 40 * R40Encode(str[6]) + R40Encode(str[7]);
            i3 = 1600 * R40Encode(str[8]) + 40 * R40Encode(str[9]) + R40Encode(str[10]);
            s0 = i0.ToString("X");
            s0 = szeroes.Substring(0, 3 - s0.Length) + s0;    // Pad on left with zeroes
            s1 = i1.ToString("X");
            s1 = szeroes.Substring(0, 4 - s1.Length) + s1;    // Pad on left with zeroes
            s2 = i2.ToString("X");
            s2 = szeroes.Substring(0, 4 - s2.Length) + s2;    // Pad on left with zeroes
            s3 = i3.ToString("X");
            s3 = szeroes.Substring(0, 4 - s3.Length) + s3;    // Pad on left with zeroes
            laLotHex.Text = s0 + " " + s1 + " " + s2 + " " + s3;
            laLotShift.Text = s0 + s1 + s2 + s3;
            return 0;
        }

        void SumItUp()
        // Concatinate the individual shifted binary strings to make final rfid string
        {
            String str;
            long val;
            String szeroes = "000000000000";

            str = laHeaderShift.Text;
            val = 4 * lgtin;     // Shift left 2 bits
            int idx = cxDateType.SelectedIndex;
            if (idx < 0)
                idx = 0;
            else if (idx > 3)
                idx = 3;
            val += idx;
            String sgtindt = val.ToString("X");
            str = str + szeroes.Substring(0, 12 - sgtindt.Length) + sgtindt;
            str = str + laDateValueShift.Text.Substring(0, 3);
            val = Convert.ToInt64(laDateValueShift.Text.Substring(3, 1), 16);
            val = Convert.ToInt64(laDateValueShift.Text.Substring(3, 1), 16);
            val = val + Convert.ToInt64(laLotShift.Text.Substring(0, 1), 16);
            str = str + val.ToString("X");
            str = str + laLotShift.Text.Substring(1, 14);
            laRFIDOut.Text = str;
            cxEPC.Text = str;
            cx128In.Text = "01" + cxGTIN.Text + cxDateType.Text.Substring(1, 2) + "2" + cxDate.Text + "10" + cxLotNum.Text;
            la128HR.Text = "(01) " + cxGTIN.Text + " (" + cxDateType.Text.Substring(1, 2) + ") 2" + cxDate.Text + " (10) " + cxLotNum.Text;
            cxQrIn.Text = cxQRHead.Text + "/01/" + cxGTIN.Text + "/" + cxDateType.Text.Substring(1, 2) + "/2" + cxDate.Text + "/10/" + cxLotNum.Text
                + "/21/" + cxSerNum.Text;
        }

        void myChanged()
        // Respond to any change in input by reencoding rfid stream
        {
            long lgtin;
            int chkError = 0;

            ClearErrors();

            if (CheckHeader() < 0)
                chkError = -1;
            if ((lgtin = CheckGTIN()) < 0)
                chkError = -2;
            else
            {
                CvtGTIN();
                if (bDecoding == 0)
                    genChkDigit(cxGTIN.Text);
            }
            CheckDateType();    // No possible error
            if (CheckDate() < 0)
                chkError = -3;
            if (CheckLot() < 0)
                chkError = -4;

            if (chkError >= 0)    // If there were no errors
            {
                SumItUp();
                if (bDecoding == 1)
                {
                    // See if rfid and encoded strings match
                    int lenE = cxEPC.Text.Length;
                    int lenR = laRFIDOut.Text.Length;
                    if (lenR == lenE)
                    {
                        for (int i = 0; i < lenE; i++)
                        {
                            if (cxEPC.Text[i] != laRFIDOut.Text[i])
                            {
                                cxEPC.ForeColor = Color.Red;    // ! Program error
                                laRFIDOut.ForeColor = Color.Red;
                                PostErrorMsg("Error in decoding.");
                                return;    // Error
                            }
                        }
                    }
                    else
                    {
                        cxEPC.ForeColor = Color.Red;    // ! Program error
                        laRFIDOut.ForeColor = Color.Red;
                        PostErrorMsg("Decoded length does not match.");
                        return;    // Error
                    }
                }
                drawBitmaps();
            }
        }

        private void cxHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxHeader_TextUpdate(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxGTIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxGTIN_TextUpdate(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxDate_TextUpdate(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxLot_TextUpdate(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxSerNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxSerNum_TextUpdate(object sender, EventArgs e)
        {
            myChanged();
        }

        public Bitmap ToBitMap1D(int dotHeight, int pixelPerDot, IBarcodeIntCS code)
        // Create the Code-128 bitmap
        {
            int pivot = code.OutLength();
            if (pixelPerDot < 1) throw new Exception("Pixel per dot < 1");
            int height = dotHeight * pixelPerDot;
            Bitmap bmp = new Bitmap(pivot * pixelPerDot, height);
            for (int x = 0; x < pivot; x++)
            {
                int color = code.At(x, 0) ? 0 : 255;
                for (int y = 0; y < height; y++)
                {
                    for (int p = 0; p < pixelPerDot; p++)
                        bmp.SetPixel((x * pixelPerDot) + p, y, Color.FromArgb(255, color, color, color));
                }
            }
            return bmp;
        }

        public Bitmap ToBitMap2D(int pixelPerDot, IBarcode code)
        // Create the QR-code bitmap
        {
            int pivot = code.OutLength();
            if (pixelPerDot < 1) throw new Exception("Pixel per dot < 1");
            int size = pivot * pixelPerDot;
            Bitmap bmp = new Bitmap(size, size);
            for (int yy = 0; yy < pivot; yy++)    // For each row
            {
                int ybase = yy * pixelPerDot;
                for (int xx = 0; xx < pivot; xx++)    // for each dot in row
                {
                    int xbase = xx * pixelPerDot;
                    int color = code.At(xx, yy) ? 0 : 255;
                    Color colorTRGB = Color.FromArgb(255, color, color, color);
                    for (int y = 0; y < pixelPerDot; y++)    // Draw a square
                    {
                        int ybase2 = ybase + y;
                        for (int x = 0; x < pixelPerDot; x++)
                            bmp.SetPixel(xbase + x, ybase2, colorTRGB);
                    }
                }
            }
            return bmp;
        }

        void drawBitmaps()
        // Create the bitmaps
        {
            // Code-128
            String inStr = cx128In.Text;
            inStr = Constants.FNC1 + inStr;
            IBarcodeIntCS code = Code128Encoder.Encode(inStr);
            string encoded = string.Empty;
            Bitmap my128Bitmap = ToBitMap1D(50, (int)udPixPerX128.Value, code);
            px128.Image = my128Bitmap;
            px128.Width = my128Bitmap.Width;
            px128.Height = my128Bitmap.Height;

            // QR
            IBarcode codeQR = QrEncoder.Encode(cxQrIn.Text, ErrorCorrectionLevel.L, Encoding.Unicode) as QrCode;
            Bitmap myQRBitmap = ToBitMap2D((int)udPixPerXQR.Value, codeQR);
            pxQR.Image = myQRBitmap;
            pxQR.Width = myQRBitmap.Width;
            pxQR.Height = myQRBitmap.Height;
        }

        private void udPixPerXQR_Click(object sender, EventArgs e)
        {
            drawBitmaps();
        }

        private void udPixPerX128_Click(object sender, EventArgs e)
        {
            drawBitmaps();
        }

        private void bnRefresh_Click(object sender, EventArgs e)
        {
            la128HR.Text = "";
            drawBitmaps();
        }

        private void cxQRHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            myChanged();
        }

        private void cxQRHead_TextUpdate(object sender, EventArgs e)
        {
            myChanged();
        }

        void bnDecode_Click(object sender, EventArgs e)
        // Decode rfid string into components
        {
            String str, str2, sgtin;
            int c0;
            long val, valgtin;
            int lot;
            String szeroes = "00000000000000";  // 14 Digits

            bDecoding = 1;
            ClearErrors();
            // Check string length
            str = cxEPC.Text;
            str2 = "";
            if (str.Length != 32)
            {
                cxEPC.BackColor = Color.Red;
                PostErrorMsg("Invalid EPC length. Needs 32 hex digits.");
                return;
            }
            // Check for hex characters
            for (int i = 0; i < 32; i++)
            {
                c0 = str[i];
                if ((c0 >= 'a') && (c0 <= 'f'))
                    c0 = char.ToUpper((char)c0);
                if (((c0 >= '0') && (c0 <= '9'))
                    || ((c0 >= 'A') && (c0 <= 'F')))
                {
                    str2 = str2 + (char)c0;
                }
                else
                {
                    cxEPC.BackColor = Color.Red;
                    PostErrorMsg("Invalid hex character.");
                    return;
                }
            }
            // Decode components
            // Header
            cxHeader.Text = str2.Substring(0, 2);

            // GTIN & date type
            val = Convert.ToInt64(str2.Substring(2, 12), 16);
            valgtin = val / 4;
            sgtin = valgtin.ToString();
            sgtin = szeroes.Substring(0, 14 - sgtin.Length) + sgtin;
            cxGTIN.Text = sgtin;
            cxDateType.SelectedIndex = (int)(val & 0x03);

            if ((valgtin = CheckGTIN()) < 0)
            {
                return;    // Error
            }
            else
            {
                CvtGTIN();
                if (bDecoding == 0)
                    genChkDigit(cxGTIN.Text);
            }


            // Date value
            val = Convert.ToInt64(str2.Substring(14, 4), 16);
            if (DecodeDate((int)(val / 0x8)) < 0)
                return;    // Error

            // Lot
            val = Convert.ToInt64(str2.Substring(17, 3), 16);
            lot = (int)(val & 0x7FF);
            if (lot >= 1600)
            {
                cxEPC.BackColor = Color.Red;
                PostErrorMsg("Lot number encoded incorrectly.");
                return;    // Error
            }
            str = "";
            str = str + R40Decode(lot / 40);
            lot = lot - (lot / 40) * 40;
            str = str + R40Decode(lot);
            for (int i = 0; i < 3; i++)
            {
                lot = Convert.ToInt32(str2.Substring(20 + 4 * i, 4), 16);
                if (lot >= 64000)
                {
                    cxEPC.BackColor = Color.Red;
                    PostErrorMsg("Lot number encoded incorrectly.");
                    return;    // Error
                }
                str = str + R40Decode(lot / 1600);
                lot = lot - (lot / 1600) * 1600;
                str = str + R40Decode(lot / 40);
                lot = lot - (lot / 40) * 40;
                str = str + R40Decode(lot);
            }
            cxLotNum.Text = str;
            myChanged();
            bDecoding = 0;
        }
    }
}
