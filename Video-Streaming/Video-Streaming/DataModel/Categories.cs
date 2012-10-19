using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Streaming.Data;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Video_Streaming.Data
{
    class Categories<T> : ObservableCollection<Data.CategoryModel>, ISupportIncrementalLoading
    {
        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {
            CoreDispatcher dispatcher = Window.Current.Dispatcher;

            return Task.Run<LoadMoreItemsResult>(
                () =>
                {
                    dispatcher.RunAsync(
                        CoreDispatcherPriority.Normal,
                        async () =>
                        {
                           
                            IEnumerable<StreamModel> streams = await Justin.Stream.List();
                            foreach (StreamModel item in streams) {
                                ((List<StreamModel>)this.First().Stream).Add(item);
                            }
                        });

                    return new LoadMoreItemsResult() { Count = 100 };

                }).AsAsyncOperation<LoadMoreItemsResult>();
        }
    
        public bool HasMoreItems
        {
	        get { return true; }
        }
    }
}
