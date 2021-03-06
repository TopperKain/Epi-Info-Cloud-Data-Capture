﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.calitha.goldparser;

namespace Epi.Core.EnterInterpreter.Rules
{
    public partial class Rule_STRLEN : EnterRule
    {
        object _result = null;
        object _fullString = null;
        object _startIndex = 0;
        object _length = 0;

        private List<EnterRule> ParameterList = new List<EnterRule>();

        public Rule_STRLEN(Rule_Context pContext, NonterminalToken pToken)
            : base(pContext)
        {
            this.ParameterList = EnterRule.GetFunctionParameters(pContext, pToken);
        }
        /// <summary>
        /// returns a substring index is 1 based ie 1 = first character
        /// </summary>
        /// <returns>object</returns>
        public override object Execute()
        {
            _fullString = null;
            _length = null;

            _fullString = this.ParameterList[0].Execute();

            if (_fullString is string)
            { 
                string fullString = _fullString.ToString();
                _length = fullString.Length;
            }

            return _length;
        }

        public override void ToJavaScript(StringBuilder pJavaScriptBuilder)
        {
            pJavaScriptBuilder.Append("CCE_StrLEN(");
            this.ParameterList[0].ToJavaScript(pJavaScriptBuilder);
            pJavaScriptBuilder.Append(")");
        }

    }
}
