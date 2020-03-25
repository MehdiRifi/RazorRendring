using System;
using System.Threading.Tasks;

namespace RazorRendering
{
    public interface IViewRender
    {
        /// <summary>
        /// Render Razor file.
        /// </summary>
        /// <param name="name"> name of the razor file</param>
        /// <returns></returns>
        Task<string> RenderAsync(string name);

        /// <summary>
        /// Render Razor file.
        /// </summary>
        /// <typeparam name="TModel"></typeparam>
        /// <param name="name"> name of the razor file</param>
        /// <param name="model"> the object to be passed to the razor file</param>
        /// <returns></returns>
        Task<string> RenderAsync<TModel>(string name, TModel model);
    }
}
