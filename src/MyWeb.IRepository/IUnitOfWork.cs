using System;
using System.Collections.Generic;
using System.Text;

namespace MyWeb.IRepository
{
    /// <summary>
    /// 工作单元接口
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        //是否提交成功
        bool Commit();
    }
}
