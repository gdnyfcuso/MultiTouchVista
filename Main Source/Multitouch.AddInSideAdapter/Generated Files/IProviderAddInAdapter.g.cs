//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.Contracts.AddInSideAdapters
{
    
    public class IProviderAddInAdapter
    {
        internal static Multitouch.Contracts.IProvider ContractToViewAdapter(Multitouch.Contracts.Contracts.IProviderContract contract)
        {
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IProviderViewToContractAddInAdapter))))
            {
                return ((IProviderViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IProviderContractToViewAddInAdapter(contract);
            }
        }
        internal static Multitouch.Contracts.Contracts.IProviderContract ViewToContractAdapter(Multitouch.Contracts.IProvider view)
        {
            if (view.GetType().Equals(typeof(IProviderContractToViewAddInAdapter)))
            {
                return ((IProviderContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IProviderViewToContractAddInAdapter(view);
            }
        }
    }
}
