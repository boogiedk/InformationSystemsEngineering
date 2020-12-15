namespace InformationSystemsEngineering.Patterns._2.ObserverIterator.Visitor.Models
{
    public class TruckModel
    {
        public string TruckName { get; set; }
        public int TruckWeight { get; set; }
        public string TruckСondition { get; set; }
        
        public void AcceptVisitor(ICarVisitor carVisitor)
        {
            carVisitor.Visit(this);
        }
    }
}