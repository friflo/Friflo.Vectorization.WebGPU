namespace Friflo.Vectorization.WebGPU;


[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
internal sealed class NativeTypeNameAttribute : Attribute
{
    public NativeTypeNameAttribute(string name) => Name = name;
    public string Name { get; }
}

