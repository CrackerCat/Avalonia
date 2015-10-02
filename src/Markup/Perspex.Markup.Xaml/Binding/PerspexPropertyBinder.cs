﻿// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using OmniXaml.TypeConversion;

namespace Perspex.Markup.Xaml.Binding
{
    public class PerspexPropertyBinder : IPerspexPropertyBinder
    {
        private readonly HashSet<XamlBinding> _bindings;

        public PerspexPropertyBinder(ITypeConverterProvider typeConverterProvider)
        {
            TypeConverterProvider = typeConverterProvider;
            _bindings = new HashSet<XamlBinding>();
        }

        public ITypeConverterProvider TypeConverterProvider { get; }

        public XamlBinding GetBinding(PerspexObject po, PerspexProperty pp)
        {
            throw new NotImplementedException();
            //return _bindings.First(xamlBinding => xamlBinding.Target == po && xamlBinding.TargetProperty == pp);
        }

        public IEnumerable<XamlBinding> GetBindings(PerspexObject source)
        {
            throw new NotImplementedException();
            //return from binding in _bindings
            //       where binding.Target == source
            //       select binding;
        }

        public XamlBinding Create(XamlBindingDefinition xamlBinding)
        {
            throw new NotImplementedException();
            //if (xamlBinding.Target == null)
            //{
            //    throw new InvalidOperationException();
            //}

            //if (xamlBinding.TargetProperty == null)
            //{
            //    throw new InvalidOperationException();
            //}

            //var binding = new XamlBinding(TypeConverterProvider)
            //{
            //    BindingMode = xamlBinding.BindingMode,
            //    SourcePropertyPath = xamlBinding.SourcePropertyPath,
            //    Target = xamlBinding.Target,
            //    TargetProperty = xamlBinding.TargetProperty
            //};

            //_bindings.Add(binding);
            //return binding;
        }
    }
}