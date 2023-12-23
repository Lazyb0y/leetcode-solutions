public class Solution {
    public bool IsPathCrossing(string path) {
        bool[,] pathArray = new bool[path.Length + 2, path.Length + 2];
        int currentX = path.Length / 2 + 1;
        int currentY = path.Length / 2 + 1;

        pathArray[currentX, currentY] = true;

        for (int i = 0; i < path.Length; i++)
        {
            switch (path[i])
            {
                case 'N':
                    currentY++;
                    break;
                case 'S':
                    currentY--;
                    break;
                case 'E':
                    currentX++;
                    break;
                case 'W':
                    currentX--;
                    break;
            }

            if (pathArray[currentX, currentY])
            {
                return true;
            }

            pathArray[currentX, currentY] = true;
        }

        return false;
    }
}