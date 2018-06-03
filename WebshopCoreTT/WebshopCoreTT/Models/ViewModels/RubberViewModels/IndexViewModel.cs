using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebshopCoreTT.Models.Domain;

namespace WebshopCoreTT.Models.ViewModels.RubberViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Rubber> Rubbers { get; set; }
        public Dictionary<string, int> ManufacturerCounterDictionary { get; set; }

        public IndexViewModel(IEnumerable<Rubber> rubbers, Dictionary<string, int> manufacturerCounterDictionary)
        {
            Rubbers = rubbers;
            ManufacturerCounterDictionary = manufacturerCounterDictionary;
        }
    }
}
