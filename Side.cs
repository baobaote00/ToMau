namespace GraphColoring
{
    class Side
    {
        private Point point1;
        private Point point2;
        private string name;

        internal Point Point1 { get => point1; set => point1 = value; }
        internal Point Point2 { get => point2; set => point2 = value; }
        public string Name { get => name; set => name = value; }

        public Side(Point no1, Point no2)
        {
            this.Point1 = no1;
            this.Point2 = no2;
            this.Name = no1.Name + " <> " + no2.Name;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
