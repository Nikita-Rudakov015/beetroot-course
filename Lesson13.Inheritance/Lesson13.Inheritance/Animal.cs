namespace Lesson13.Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int PawsCount { get; set; }
        public int Size { get; set; }

        public virtual void MakeNoise()
        {

        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;

            if (ReferenceEquals(obj, null)) return false;

            Animal? cat = obj as Animal;                     //savecast к типу данных в который хотим перевести
            if (cat == null)
            {
                return false;
            }

            if (this.Name != cat.Name) return false;
            if (this.Size != cat.Size) return false;
            if (this.PawsCount != cat.PawsCount) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
