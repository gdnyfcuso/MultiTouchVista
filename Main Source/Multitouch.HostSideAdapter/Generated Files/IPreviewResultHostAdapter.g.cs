//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.HostSideAdapters
{
    
    public class IPreviewResultHostAdapter
    {
        internal static Multitouch.IPreviewResult ContractToViewAdapter(Multitouch.Contracts.IPreviewResultContract contract)
        {
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IPreviewResultViewToContractHostAdapter))))
            {
                return ((IPreviewResultViewToContractHostAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IPreviewResultContractToViewHostAdapter(contract);
            }
        }
        internal static Multitouch.Contracts.IPreviewResultContract ViewToContractAdapter(Multitouch.IPreviewResult view)
        {
            if (view.GetType().Equals(typeof(IPreviewResultContractToViewHostAdapter)))
            {
                return ((IPreviewResultContractToViewHostAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IPreviewResultViewToContractHostAdapter(view);
            }
        }
    }
}

