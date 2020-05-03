using System.Collections.Generic;


namespace YGrammar
{
    public class Program
    {
        public IReadOnlyList<Import> Imports { get; }
        public IReadOnlyList<Constant> Constants { get; }
        public IReadOnlyList<StructDefinition> Structs { get; }
        public IReadOnlyList<CallableDefinition> Callables { get; }

        public MainBody? Main { get; }

        public Program(IReadOnlyList<Import> imports, IReadOnlyList<Constant> constants, IReadOnlyList<StructDefinition> structs, IReadOnlyList<CallableDefinition> callables, MainBody? main)
        {
            Imports = imports;
            Constants = constants;
            Structs = structs;
            Callables = callables;
            Main = main;
        }
    }
}
