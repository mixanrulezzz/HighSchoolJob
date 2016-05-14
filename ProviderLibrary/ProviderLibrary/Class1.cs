using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProviderLibrary
{
    public class Provider
    {
        public int ProviderID;
        public string ProviderName;

        public Provider()
        { }

        public Provider(int ProviderID, string ProviderName)
        {
            this.ProviderID = ProviderID;
            this.ProviderName = ProviderName;
        }

        public override string ToString()
        {
            return ProviderID.ToString() + " " + ProviderName;
        }
    }

    public class ProviderList
    {
        public List<Provider> Providers;

        public ProviderList()
        {
            Providers = new List<Provider>();
        }

        public int Add(Provider NewElement)
        {
            if (NewElement.ProviderName.Length > 40)
                return 1;
            Providers.Add(NewElement);
            return 0;
        }

        public int Add(int ProviderID, string ProviderName)
        {
            if (ProviderName.Length > 40)
                return 1;
            Providers.Add(new Provider(ProviderID, ProviderName));
            return 0;
        }

        public bool UpdateAt(Provider UpdElement, int ElementIndex)
        {
            Providers[ElementIndex] = UpdElement;
            return true;
        }

        public bool Remove(Provider DelElement)
        {
            try { Providers.Remove(DelElement); }
            catch (Exception) { return false; }
            return true;
        }

        public bool RemoveAt(int ProviderIndex)
        {
            try { Providers.RemoveAt(ProviderIndex); }
            catch (Exception) { return false; }
            return true;
        }

        public Provider this[int i]
        {
            get { return Providers[i]; }
            set { Providers[i] = value; }
        }

        public int Count
        {
            get { return Providers.Count; }
        }
    }
}
