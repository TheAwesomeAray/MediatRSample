using System;
using System.Linq.Expressions;

namespace SharedKernel
{
    public abstract class BaseSpecification<T>
    {
        protected BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; }
    }
}
