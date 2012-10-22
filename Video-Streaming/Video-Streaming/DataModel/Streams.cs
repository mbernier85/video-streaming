using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    class Streams<T> : ObservableCollection<Data.StreamModel>, ISupportIncrementalLoading
    {
        private uint countThis;

        public IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {
            countThis += count;
            CoreDispatcher dispatcher = Window.Current.Dispatcher;

                return Task.Run<LoadMoreItemsResult>(
                    () =>
                    {
                        dispatcher.RunAsync(
                            CoreDispatcherPriority.Normal,
                            async () =>
                            {

                                Streams<StreamModel> streams = await Justin.Stream.List();
                                foreach (StreamModel item in streams)
                                {
                                    this.Add(item);
                                }
                            }).AsTask().Wait();
                        return new LoadMoreItemsResult() { Count = 100 };

                    }).AsAsyncOperation<LoadMoreItemsResult>();

        }
    
        public bool HasMoreItems
        {
            get {
                return (countThis < 500); 
                }
        }
    }
}
