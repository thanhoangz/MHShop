using AutoMapper;
using MH.Model.Models;
using MH.Service;
using MH.Web.Models;
using System.Web.Mvc;


namespace MH.Web.Controllers
{
    public class PageController : Controller
    {
        IPageService _pageService;
        public PageController(IPageService pageService)
        {
            this._pageService = pageService;
        }
        // GET: Page
        public ActionResult Index(string alias)
        {
            var page = _pageService.GetByAlias(alias);
            var model = Mapper.Map<Page, PageViewModel>(page);
            return View(model);
        }
    }
}