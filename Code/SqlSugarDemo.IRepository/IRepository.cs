using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarDemo.IRepository
{
    public interface IRepository<T>
    {
        #region Query
        #region Query Single
        ///// <summary>
        ///// Query
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //T Query(object id);
        #endregion


        #region Query All
        /// <summary>
        /// Query All
        /// </summary>
        /// <returns></returns>
        IList<T> QueryAll();

        ///// <summary>
        ///// Query All
        ///// </summary>
        ///// <param name="keySelector"></param>
        ///// <param name="asc"></param>
        ///// <returns></returns>
        //IList<T> QueryAll<TKey>(Expression<Func<T, TKey>> keySelector, bool asc);

        ///// <summary>
        ///// Query All
        ///// </summary>
        ///// <param name="lsWhere"></param>
        ///// <returns></returns>
        //IList<T> QueryAll(Expression<Func<T, bool>> where);

        ///// <summary>
        ///// Query All
        ///// </summary>
        ///// <param name="lsWhere"></param>
        ///// <returns></returns>
        //IList<T> QueryAll(IList<Expression<Func<T, bool>>> lsWhere);

        ///// <summary>
        ///// Query All
        ///// </summary>
        ///// <typeparam name="TKey"></typeparam>
        ///// <param name="lsWhere"></param>
        ///// <param name="keySelector"></param>
        ///// <param name="asc"></param>
        ///// <returns></returns>
        //IList<T> QueryAll<TKey>(IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, TKey>> keySelector, bool asc);

        ///// <summary>
        ///// Query All
        ///// </summary>
        ///// <typeparam name="TKey"></typeparam>
        ///// <param name="where"></param>
        ///// <param name="keySelector"></param>
        ///// <param name="asc"></param>
        ///// <returns></returns>
        //IList<T> QueryAll<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> keySelector, bool asc);
        //#endregion


        //#region Query Paging
        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <returns></returns>
        //IList<T> QueryPaging(int page, int size, out int count);

        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <returns></returns>
        //IList<T> QueryPaging<TKey>(int page, int size, out int count, Expression<Func<T, TKey>> keySelector, bool asc);

        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //IList<T> QueryPaging(int page, int size, out int count, Expression<Func<T, bool>> where);

        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <param name="lsWhere"></param>
        ///// <returns></returns>
        //IList<T> QueryPaging(int page, int size, out int count, IList<Expression<Func<T, bool>>> lsWhere);

        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <typeparam name="TKey"></typeparam>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <param name="lsWhere"></param>
        ///// <param name="keySelector"></param>
        ///// <param name="asc"></param>
        ///// <returns></returns>
        //IList<T> QueryPaging<TKey>(int page, int size, out int count, IList<Expression<Func<T, bool>>> lsWhere, Expression<Func<T, TKey>> keySelector, bool asc);

        ///// <summary>
        ///// Query Paging
        ///// </summary>
        ///// <typeparam name="TKey"></typeparam>
        ///// <param name="page"></param>
        ///// <param name="size"></param>
        ///// <param name="count"></param>
        ///// <param name="where"></param>
        ///// <param name="keySelector"></param>
        ///// <param name="asc"></param>
        ///// <returns></returns>
        //IList<T> QueryPaging<TKey>(int page, int size, out int count, Expression<Func<T, bool>> where, Expression<Func<T, TKey>> keySelector, bool asc);
        #endregion
        #endregion


        #region Add
        ///// <summary>
        ///// Add
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //object Add(T entity);

        ///// <summary>
        ///// Add
        ///// </summary>
        ///// <param name="entities"></param>
        ///// <returns></returns>
        //IList<object> Add(IList<T> entities);
        #endregion


        #region Update
        ///// <summary>
        ///// Update
        ///// </summary>
        ///// <param name="entity"></param>
        ///// <returns></returns>
        //void Update(T entity);

        ///// <summary>
        ///// Update
        ///// </summary>
        ///// <param name="entities"></param>
        ///// <returns></returns>
        //void Update(IList<T> entities);
        #endregion


        #region Delete
        ///// <summary>
        ///// Delete
        ///// </summary>
        ///// <param name="entity"></param>
        //void Delete(T entity);

        ///// <summary>
        ///// Delete
        ///// </summary>
        ///// <param name="key"></param>
        //void Delete(object key);
        #endregion
    }
}
