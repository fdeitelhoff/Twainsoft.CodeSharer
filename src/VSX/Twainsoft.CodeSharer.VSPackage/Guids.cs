// Guids.cs
// MUST match guids.h
using System;

namespace Twainsoft.Twainsoft_CodeSharer_VSX
{
    static class GuidList
    {
        public const string guidTwainsoft_CodeSharer_VSXPkgString = "74a07d01-54f1-417f-a984-1fd448925016";
        public const string guidTwainsoft_CodeSharer_VSXCmdSetString = "7d558044-c632-4ef0-8233-dfd74a5a9035";
        public const string guidToolWindowPersistanceString = "9599ef85-2ac0-4dfe-9e0f-e83a812102db";

        public static readonly Guid guidTwainsoft_CodeSharer_VSXCmdSet = new Guid(guidTwainsoft_CodeSharer_VSXCmdSetString);
    };
}