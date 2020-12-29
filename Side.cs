namespace GraphColoring
{
    class Side
    {
        private Points point1;
        private Points point2;
        private string name;

        internal Points Point1 { get => point1; set => point1 = value; }
        internal Points Point2 { get => point2; set => point2 = value; }
        public string Name { get => name; set => name = value; }

        public Side(Points no1, Points no2)
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
