using System;
using System.Linq.Expressions;

namespace Request.Specifications
{
    public abstract class BaseSpecification<T>
    {
        protected BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; }
        public bool Evaluate(T source) => Criteria.Compile()(source);
    }
}
