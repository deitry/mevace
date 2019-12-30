namespace mevace.Models
{
    public class EmpireModel
    {
        public EmpireModel(int id, string name) { this.Id = id; this.Name = name; this.GoldAmount = 0; }

        public int Id { get; set; }
        public string Name { get; set; }

        public int GoldAmount { set; get; }

        public string Greeting()
        {
            return $"Hello, this is {this.Name} President speaking";
        }
    }
}
