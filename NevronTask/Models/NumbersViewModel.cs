using System.ComponentModel;

namespace NevronTask.Models
{
    public class NumbersViewModel
    {
        public NumbersViewModel()
        {
            if(this.Elements == null)
            {
                this.Elements = new List<int>();
            }
        }
        [DisplayName("Sum Of all Elements")]
        public int Sum { get; set; }
        [DisplayName("Elements")]
        public List<int> Elements { get; set; }
    }
}
