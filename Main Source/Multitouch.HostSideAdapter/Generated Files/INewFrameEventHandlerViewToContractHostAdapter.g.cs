//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3069
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.Contracts.HostSideAdapters
{
    
    public class INewFrameEventHandlerViewToContractHostAdapter : System.AddIn.Pipeline.ContractBase, Multitouch.Contracts.Contracts.INewFrameEventHandlerContract
    {
        private object _view;
        private System.Reflection.MethodInfo _event;
        public INewFrameEventHandlerViewToContractHostAdapter(object view, System.Reflection.MethodInfo eventProp)
        {
            _view = view;
            _event = eventProp;
        }
        public void Handler(Multitouch.Contracts.Contracts.INewFrameEventArgsContract args)
        {
            Multitouch.Contracts.HostSideAdapters.NewFrameEventArgsContractToViewHostAdapter adaptedArgs;
            adaptedArgs = new Multitouch.Contracts.HostSideAdapters.NewFrameEventArgsContractToViewHostAdapter(args);
            object[] argsArray = new object[1];
            argsArray[0] = adaptedArgs;
            _event.Invoke(_view, argsArray);
        }
        internal object GetSourceView()
        {
            return _view;
        }
    }
}
