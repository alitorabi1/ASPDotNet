namespace PList
{
    internal class ListBoxItem
    {
        private string Name;
        private int Age;

        public ListBoxItem(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString() { return Name + " is " + Age + " years old."; }

    }
}