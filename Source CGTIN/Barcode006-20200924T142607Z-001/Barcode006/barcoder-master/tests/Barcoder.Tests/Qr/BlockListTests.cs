using System.Collections.Generic;
using Barcoder.Qr;
using FluentAssertions;
using Xunit;

namespace Barcoder.Tests.Qr
{
    public sealed class BlockListTests
    {
        [Theory]
        [InlineData(15, 16, new byte[] { 67, 246, 182, 70, 85, 246, 230, 247, 70, 66, 247, 118, 134, 7, 119, 86, 87, 118, 50, 194, 38, 134, 7, 6, 85, 242, 118, 151, 194, 7, 134, 50, 119, 38, 87, 16, 50, 86, 38, 236, 6, 22, 82, 17, 18, 198, 6, 236, 6, 199, 134, 17, 103, 146, 151, 236, 38, 6, 50, 17, 7, 236, 213, 87, 148, 235, 199, 204, 116, 159, 11, 96, 177, 5, 45, 60, 212, 173, 115, 202, 76, 24, 247, 182, 133, 147, 241, 124, 75, 59, 223, 157, 242, 33, 229, 200, 238, 106, 248, 134, 76, 40, 154, 27, 195, 255, 117, 129, 230, 172, 154, 209, 189, 82, 111, 17, 10, 2, 86, 163, 108, 131, 161, 163, 240, 32, 111, 120, 192, 178, 39, 133, 141, 236 })]
        [InlineData(16, 15, new byte[] { 67, 246, 247, 247, 85, 66, 119, 118, 70, 7, 50, 86, 134, 118, 7, 194, 87, 134, 118, 6, 38, 242, 134, 151, 85, 7, 87, 50, 194, 38, 38, 16, 119, 86, 82, 236, 50, 22, 6, 17, 6, 198, 134, 236, 18, 199, 151, 17, 6, 146, 50, 236, 103, 6, 7, 17, 38, 182, 70, 236, 246, 230, 71, 101, 27, 62, 13, 91, 166, 86, 138, 16, 78, 229, 102, 11, 199, 107, 2, 182, 132, 103, 89, 66, 136, 69, 78, 255, 116, 129, 126, 163, 219, 234, 158, 216, 42, 234, 97, 62, 186, 59, 123, 148, 220, 191, 254, 145, 82, 95, 129, 79, 236, 254, 30, 174, 228, 50, 181, 110, 150, 205, 34, 235, 242, 0, 115, 147, 58, 243, 28, 140, 221, 219 })]
        public void SplitToBlocksAndInterleave_ShouldReturnCorrectResult(byte dataCodewordsPerBlockInGroup1, byte dataCodewordsPerBlockInGroup2, byte[] expectedInterleaveResult)
        {
            // Arrange
            var versionInfo = new VersionInfo(5, ErrorCorrectionLevel.Q, 18, 2, dataCodewordsPerBlockInGroup1, 2, dataCodewordsPerBlockInGroup2);
            var data = new byte[] { 67, 85, 70, 134, 87, 38, 85, 194, 119, 50, 6, 18, 6, 103, 38, 246, 246, 66, 7, 118, 134, 242, 7, 38, 86, 22, 198, 199, 146, 6, 182, 230, 247, 119, 50, 7, 118, 134, 87, 38, 82, 6, 134, 151, 50, 7, 70, 247, 118, 86, 194, 6, 151, 50, 16, 236, 17, 236, 17, 236, 17, 236 };

            // Act
            byte[] interleaveResult = BlockList.SplitToBlocks(new Queue<byte>(data), versionInfo).Interleave(versionInfo);

            // Assert
            interleaveResult.Should().BeEquivalentTo(expectedInterleaveResult);
        }
    }
}
