//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.Contracts.HostSideAdapters
{
    
    public class IInputPreviewHandlerViewToContractHostAdapter : System.AddIn.Pipeline.ContractBase, Multitouch.Contracts.Contracts.IInputPreviewHandlerContract
    {
        private Multitouch.Contracts.IInputPreviewHandler _view;
        public IInputPreviewHandlerViewToContractHostAdapter(Multitouch.Contracts.IInputPreviewHandler view)
        {
            _view = view;
        }
        public virtual Multitouch.Contracts.IPreviewResultContract Handle(Multitouch.Contracts.Contracts.IContactContract contact)
        {
            return Multitouch.HostSideAdapters.IPreviewResultHostAdapter.ViewToContractAdapter(_view.Handle(Multitouch.Contracts.HostSideAdapters.IContactHostAdapter.ContractToViewAdapter(contact)));
        }
        internal Multitouch.Contracts.IInputPreviewHandler GetSourceView()
        {
            return _view;
        }
    }
}

