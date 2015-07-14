namespace Task_2.Refactor_if_statement
{
    public class GameBoard
    {
        private void MoveBetweenCells(int x, int y, bool isCellVisited)
        {
            int minX = 0,
                maxX = 10,
                minY = 0,
                maxY = 10;

            if ((minX <= x) && (x <= maxX) && (minY <= y) && (y <= maxY) && !isCellVisited)
            {
                this.VisitCell();
            }
        }

        private void VisitCell()
        {
        }
    }
}
