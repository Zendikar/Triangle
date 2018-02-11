namespace Triangle
{
    class Triangle
    {
        private int length1;
        private int length2;
        private int length3;

        public Triangle(int length1, int length2, int length3)
        {
            this.length1 = length1;
            this.length2 = length2;
            this.length3 = length3;
        }

        public int Length1 { get => length1; set => length1 = value; }
        public int Length2 { get => length2; set => length2 = value; }
        public int Length3 { get => length3; set => length3 = value; }

        public override string ToString()
        {
            return "("+this.length1+","+this.length2+","+this.length3+")";
        }
    }
}
