﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;

namespace GraphQL.EntityFramework
{
    public partial interface IEfGraphQLService<TDbContext>
    {
        FieldType AddQueryField<TReturn>(
            IComplexGraphType graph,
            string name,
            Func<ResolveEfFieldContext<TDbContext, object>, IQueryable<TReturn>>? resolve = null,
            Type? itemGraphType = null,
            IEnumerable<QueryArgument>? arguments = null,
            string? description = null,
            bool disableDefaultArguments = false)
            where TReturn : class;

        FieldType AddQueryField<TSource, TReturn>(
            IComplexGraphType graph,
            string name,
            Func<ResolveEfFieldContext<TDbContext, TSource>, IQueryable<TReturn>>? resolve = null,
            Type? itemGraphType = null,
            IEnumerable<QueryArgument>? arguments = null,
            string? description = null,
            bool disableDefaultArguments = false)
            where TReturn : class;
        
        FieldType AddQueryField<TReturn>(
            IComplexGraphType graph,
            string name,
            Func<ResolveEfFieldContext<TDbContext, object>, Task<IQueryable<TReturn>>>? resolveAsync = null,
            Type? itemGraphType = null,
            IEnumerable<QueryArgument>? arguments = null,
            string? description = null,
            bool disableDefaultArguments = false)
            where TReturn : class;

        FieldType AddQueryField<TSource, TReturn>(
            IComplexGraphType graph,
            string name,
            Func<ResolveEfFieldContext<TDbContext, TSource>, Task<IQueryable<TReturn>>>? resolveAsync = null,
            Type? itemGraphType = null,
            IEnumerable<QueryArgument>? arguments = null,
            string? description = null,
            bool disableDefaultArguments = false)
            where TReturn : class;

        FieldType AddUnionQueryField<TUnion>(
            IComplexGraphType graph,
            string name,
            Func<ResolveEfFieldContext<TDbContext, object>, IDictionary<Type, IQueryable<object>>>? resolve = null,
            IEnumerable<QueryArgument>? arguments = null,
            string? description = null) where TUnion : UnionGraphType;

        FieldType AddUnionQueryField<TUnion, TSource>(
            IComplexGraphType graph,
            string name,
            Func<ResolveEfFieldContext<TDbContext, TSource>, IDictionary<Type, IQueryable<object>>>? resolve = null,
            IEnumerable<QueryArgument>? arguments = null,
            string? description = null) where TUnion : UnionGraphType;

        
        FieldType AddUnionQueryField<TUnion>(
            IComplexGraphType graph,
            string name,
            Func<ResolveEfFieldContext<TDbContext, object>, Task<IDictionary<Type, IQueryable<object>>>>? resolveAsync = null,
            IEnumerable<QueryArgument>? arguments = null,
            string? description = null) where TUnion : UnionGraphType;

        FieldType AddUnionQueryField<TUnion, TSource>(
            IComplexGraphType graph,
            string name,
            Func<ResolveEfFieldContext<TDbContext, TSource>, Task<IDictionary<Type, IQueryable<object>>>>? resolveAsync = null,
            IEnumerable<QueryArgument>? arguments = null,
            string? description = null) where TUnion : UnionGraphType;
    }
}