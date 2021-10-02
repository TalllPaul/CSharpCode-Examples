using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You can add another interface to this one to add the elements from one 'contract' to the other, therefore we can access all elements from both interfaces rather than just what is stated
//in one.
namespace DemoLibrary
{
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
