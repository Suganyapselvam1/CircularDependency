using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularDependency
{
    public interface IDependencies
    {
        
    }
    public interface IVechile
    {

    }
    public interface IHome
    {

    }
    public class Dependencies : IDependencies
    {
        private IVechile _vechile;
        public Dependencies(IVechile vechile)
        {
            this._vechile = vechile;
        }
    }
    public class Vechile : IVechile
    {
        private IHome _home;
        public Vechile(IHome home)
        {
            this._home = home;
        }
    }
    public class Home : IHome
    {
        private IDependencies _dependencies;
        public Home(IDependencies dependencies)
        {
            _dependencies = dependencies;
        }
    }
}
