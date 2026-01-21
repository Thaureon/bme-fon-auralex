public class Solution {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        var areaA = (ay2 - ay1) * (ax2 - ax1);
        var areaB = (by2 - by1) * (bx2 - bx1);
        
        var totalArea = areaA + areaB;

        var cx1 = Math.Max(ax1, bx1);
        var cy1 = Math.Max(ay1, by1);
        var cx2 = Math.Min(ax2, bx2);
        var cy2 = Math.Min(ay2, by2);

        if(cx1 < cx2 && cy1 < cy2)
        {
            var overlapArea = (cy2 - cy1) * (cx2 - cx1);
            totalArea -= overlapArea;
        }

        return totalArea;
    }
}