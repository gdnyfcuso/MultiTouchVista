//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3069
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multitouch.Contracts.AddInSideAdapters
{
    
    public class InputTypeArrayAddInAdapter
    {
        public static Multitouch.Contracts.InputType[] ContractToViewAdapter(Multitouch.Contracts.Contracts.InputType[] contract)
        {
            Multitouch.Contracts.InputType[] result = new Multitouch.Contracts.InputType[contract.Length];
            for (int i = 0; (i < contract.Length); i = (i + 1))
            {
                result[i] = Multitouch.Contracts.AddInSideAdapters.InputTypeAddInAdapter.ContractToViewAdapter(contract[i]);
            }
            return result;
        }
        public static Multitouch.Contracts.Contracts.InputType[] ViewToContractAdapter(Multitouch.Contracts.InputType[] view)
        {
            Multitouch.Contracts.Contracts.InputType[] result = new Multitouch.Contracts.Contracts.InputType[view.Length];
            for (int i = 0; (i < view.Length); i = (i + 1))
            {
                result[i] = Multitouch.Contracts.AddInSideAdapters.InputTypeAddInAdapter.ViewToContractAdapter(view[i]);
            }
            return result;
        }
    }
}
