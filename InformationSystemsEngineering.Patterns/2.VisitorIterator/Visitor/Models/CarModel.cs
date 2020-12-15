namespace InformationSystemsEngineering.Patterns._2.ObserverIterator.Visitor.Models
{
    public class CarModel
    {
        public string CarName { get; set; }
        public int CarWeight { get; set; }
        public string CarСondition { get; set; }

        public void AcceptVisitor(ICarVisitor carVisitor)
        {
            carVisitor.Visit(this);
        }
    }
}