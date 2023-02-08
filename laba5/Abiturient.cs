public class Abiturient
    {
        public string surname, name, scndname, adress, allinfo;
        public int est;
        public object[] dannye = new object[25];
    public int[] ozenki = new int[25];
        public Abiturient(string surname, string name, string scndname, string adress)
        {
            this.allinfo = $"{this.surname}, " + $"{this.name}, " + $"{this.scndname}, " + $"{this.adress}";
        for (int i = 0; i < 1; i++)
            {
            for (int k = 0; k < 5; k++)
            {
                this.est = int.Parse(Console.ReadLine());
                ozenki[i] = this.est;
            }
            dannye[i] = this.allinfo;
            }
        }
        public Abiturient()
        {
            this.surname = "unknown";
            this.name = "unknown";
            this.scndname = "unknown";
            this.adress = "unknown";
            this.est = 0;
            this.allinfo = $"{this.surname}, " + $"{this.name}, " + $"{this.scndname}, " + $"{this.adress}, " + $"{this.est}";
        }
        /*public VvodDannyx()
        {

        }*/
    }