using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF3.Utility
{
    public static class BaseOperation
    {
        public static string CutHead(this string s)
        {
            string cutHeadS = null;
            foreach (var c in s)
            {
                if (c!=s[0])
                {
                    cutHeadS += c;
                }
            }
            return cutHeadS;
        }

        public static IQueryable<T> GetPage<T> (this DbSet<T> dbSet, int start, int count) where T : BaseEntity
        {
            return dbSet.OrderBy(x=>x.Id).Skip(start - 1).Take(count);
        }

        public static T GetById<T>(this DbSet<T> dbSet, long id) where T : BaseEntity
        {
            return dbSet.Where(t=>t.Id==id).SingleOrDefault();
        }
    }
}
