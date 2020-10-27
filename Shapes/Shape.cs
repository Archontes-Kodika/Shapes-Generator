namespace Shapes {
    public abstract class Shape
    {
        public const char ch = '*';
        public string Name {get; set;}
        public Shape(){}
        public Shape(string Name){
            this.Name = Name;
        }
        public abstract string Draw();
    }
}