﻿using LCL.MetaModel;
namespace LCL
{
    /// <summary>
    /// 系统权限的抽象定义
    /// </summary>
    public static class PermissionMgr
    {
        private static PermissionProvider _Provider;
        /// <summary>
        /// 所有接口的提供程序。
        /// </summary>
        public static PermissionProvider Provider
        {
            private get
            {
                if (_Provider == null) { _Provider = new PermissionProvider(); }

                return _Provider;
            }
            set { _Provider = value; }
        }

        /// <summary>
        /// 是否能显示某个模块
        /// </summary>
        /// <param name="module"></param>
        /// <returns></returns>
        public static bool CanShowModule(ModuleMeta module)
        {
            return Provider.CanShowModule(module);
        }
        /// <summary>
        /// 控制某一个块是否可以显示
        /// </summary>
        /// <param name="module"></param>
        /// <param name="block"></param>
        /// <returns></returns>
        public static bool CanShowBlock(ModuleMeta block)
        {
            return Provider.CanShowBlock(block);
        }
        /// <summary>
        /// 控制某一个块是否可以显示
        /// </summary>
        /// <param name="module"></param>
        /// <param name="block"></param>
        /// <returns></returns>
        public static bool CanShowBlock(ModuleMeta module, string block)
        {
            return Provider.CanShowBlock(module, block);
        }

        /// <summary>
        /// 是否有某个操作的权限
        /// </summary>
        /// <param name="module"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static bool HasOperation(ModuleMeta module, ModuleOperation operation)
        {
            return Provider.HasOperation(module, operation);
        }

        /// <summary>
        /// 是否能执行某个命令
        /// </summary>
        /// <param name="module"></param>
        /// <param name="block"></param>
        /// <param name="commandName"></param>
        /// <returns></returns>
        public static bool HasCommand(ModuleMeta module, string block, string commandName)
        {
            return Provider.HasCommand(module, block, commandName);
        }
        public static bool HasCommand(string block, string module, string commandName)
        {
            return Provider.HasCommand(block, module, commandName);
        }
    }
}