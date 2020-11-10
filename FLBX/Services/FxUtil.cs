using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace FLBX
{
    public class FxUtil : IfxUtil
    {

        public RenderFragment CreateComponent( string componentName)
        {
            return CreateComponent(null, componentName);
        }

         public RenderFragment CreateComponent(string? nameSpace, string componentName)
        {
            //todo ylee. 향후 component 배포 기능을 만들때 확장 컴포넌트를 load할 수 있는 정보로 변경 필요
            string componentNamespace = nameSpace ?? @"FLBX.Pages"; 
            //Blzor Component 로드
            IEnumerable<Type> componentTypes = Assembly.GetCallingAssembly()
                                    .GetTypes().Where(r => r.Namespace == componentNamespace);

            Type type = componentTypes.Where(r => r.Name.Equals(componentName)).FirstOrDefault();

            if (type == null)
            {
                throw new NotImplementedException($"Can not find blazor component. Component id:{componentName}");
            }

            return CreateDynamicComponent(0, type);
        }

        /// <summary>
        /// Razor 컴포넌트 다른 클래스의 속성으로 사용하기 위해 RenderFragmemt 개체로 변경
        /// </summary>
        /// <param name="seq"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        RenderFragment CreateDynamicComponent(int seq, Type type) => builder =>
        {
            builder.OpenComponent(seq, type);            
            builder.CloseComponent();
        };

        

        

    }
}
