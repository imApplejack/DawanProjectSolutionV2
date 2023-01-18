using AssociationCRMDawanPoe.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using MVCProject.Extensions;
using SqlKata;

namespace MVCProject.Models
{


    /// <summary>
    /// 
    /// </summary>
    public class OrderViewModel : PageModel
    {

        public static Order? _currentorder;

        /// <summary>
        /// Singleton
        /// </summary>
        /// <returns></returns>
        public static Order GetOrder()
        {
            if (_currentorder != null)
            {
                return _currentorder;
            }
            else
            {
                _currentorder =  new Order();
                return _currentorder;
            }
        }

        public static Order CleanOrder()
        {
            _currentorder = null;
            return GetOrder();
        }


        /// Probablement + propre d'utiliser les session mais utiliser les static fonctionne ///
        /*
        public OrderViewModel(ISession session)
        {
            _session = session;
            GetOrder();
        }

        public Order GetOrder()
        {
            if(_currentorder != null)
            {
                return _currentorder;
            }

            if (_session.Get(SessionKeyOrder) != null)
            {
                _currentorder = _session.GetObject<Order>(SessionKeyOrder);
                return _currentorder;
            }
            else
            {
                _currentorder = new Order() { Products = new List<Product> { new Product() { Name = "toto", Price = 25.0 } } }; //@todo enlever init + tard
                SaveOrder();
                return _currentorder;
            }
        }

        public Order SaveOrder()
        {
            if (_currentorder != null)
            {
                _session.SetObject(SessionKeyOrder, _currentorder);
                return _currentorder;
            }
            throw new Exception("Session Order non instancié");
        }
        */
    }
}