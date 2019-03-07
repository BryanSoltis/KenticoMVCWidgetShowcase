using CMS.DocumentEngine.Types.KenticoMVCWidgetShowcase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KenticoMVCWidgetShowcase.Repositories
{
    /// <summary>
    /// Represents a contract for a collection of mvc widgets.
    /// </summary>
    public interface IMVCWidgetRepository : IRepository
    {
        /// <summary>
        /// Returns an enumerable collection of mvc widgets ordered by the date of publication. The most recent mvc widgets come first.
        /// </summary>
        /// <param name="count">The number of mvc widgets to return. Use 0 as value to return all records.</param>
        /// <returns>An enumerable collection that contains the specified number of mvc widgets ordered by the date of publication.</returns>
        IEnumerable<MVCWidget> GetMVCWidgets(int intSelectTopN = 0);


        /// <summary>
        /// Returns the mvc widget with the specified identifier.
        /// </summary>
        /// <param name="guid">The mvc iwdget identifier.</param>
        /// <returns>The mvc widget with the specified node identifier, if found; otherwise, null.</returns>
        MVCWidget GetMVCWidget(Guid guid);
    }
}