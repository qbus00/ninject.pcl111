using System;
using Ninject.Activation;
using Ninject.Activation.Caching;
using Ninject.Activation.Strategies;
using Ninject.Injection;
using Ninject.Planning;
using Ninject.Planning.Bindings.Resolvers;
using Ninject.Planning.Strategies;
using Ninject.Selection;
using Ninject.Selection.Heuristics;

namespace Ninject
{
    /// <summary>
    /// 
    /// </summary>
    [Preserve(AllMembers = true)]
    public class LinkerPleaseInclude
    {
        private LinkerPleaseInclude()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public void Ninject()
        {
            var resolver = new StandardBindingResolver();
            var bindingResolver = new OpenGenericBindingResolver();
            var cache = new Cache(null, null);
            var pipeline = new Pipeline(null, null);
            var activationCache = new ActivationCache(null);
            var gccp = new GarbageCollectionCachePruner();
            var acs = new ActivationCacheStrategy(null);
            var pis = new PropertyInjectionStrategy(null);
            var rif = new ReflectionInjectorFactory();
            var mis = new MethodInjectionStrategy();
            var initStrategy = new InitializableStrategy();
            var startableStrategy = new StartableStrategy();
            var bas = new BindingActionStrategy();
            var ds = new DisposableStrategy();
            var planner = new Planner(null);
            var crs = new ConstructorReflectionStrategy(null, null);
            var selector = new Selector(null, null);
            var scs = new StandardConstructorScorer();
            var sih = new StandardInjectionHeuristic();
            var prs = new PropertyReflectionStrategy(null, null);
            var mrs = new MethodReflectionStrategy(null, null);
            var dvbr = new DefaultValueBindingResolver();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class PreserveAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public bool AllMembers = true;
        /// <summary>
        /// 
        /// </summary>
        public bool Conditional;
    }
}
