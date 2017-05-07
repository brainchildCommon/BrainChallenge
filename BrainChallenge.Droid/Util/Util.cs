using System;
using System.Linq;
using System.Xml.Linq;
using Android.Content;
using Android.Views;
using Android.Widget;

namespace BrainChallenge.Droid.Util
{
    internal class Util
    {
        public static T GenerateView<T>(Context context, string styleName) where T : View
        {
            var styleId = (int) typeof(Resource.Style).GetField(styleName).GetValue(null);

            var viewType = typeof(T);
            var args = new object[] {context, null, styleId, styleId};
            var view = (T) Activator.CreateInstance(viewType, args);

            var xml = XDocument.Load(context.Assets.Open("Styles.xml"));
            var styles = xml.Descendants("style");
            var stylesResult = from n in styles let xAttribute = n.Attribute("name") where xAttribute != null && xAttribute.Value.Equals(styleName) select n;
            var items = stylesResult.Descendants("item");
            var itemsResult = from n in items select n;
            var styleValues = itemsResult.ToList();

            var layoutHeight = -1;
            var layoutWidth = -1;
            var layoutMarginBottom = 0;
            var layoutMarginLeft = 0;
            var layoutMarginRight = 0;
            var layoutMarginTop = 0;
            var paddingLeft = 0;
            var paddingTop = 0;
            var paddingBottom = 0;
            var paddingRight = 0;

            foreach (var val in styleValues)
            {
                var name = val.Attribute("name").Value;

                if (name.Equals("android:layout_height"))
                {
                    if (!int.TryParse(val.Value, out layoutHeight))
                        if (val.Value.Equals("wrap_content"))
                            layoutHeight = -2;
                        else
                            layoutHeight = -1;
                }
                else if (name.Equals("android:layout_width"))
                {
                    if (!int.TryParse(val.Value, out layoutWidth))
                        if (val.Value.Equals("wrap_content"))
                            layoutWidth = -2;
                        else
                            layoutWidth = -1;
                }
                else if (name.Equals("android:layout_marginBottom"))
                {
                    int.TryParse(val.Value, out layoutMarginBottom);
                }
                else if (name.Equals("android:layout_marginLeft"))
                {
                    int.TryParse(val.Value, out layoutMarginLeft);
                }
                else if (name.Equals("android:layout_marginRight"))
                {
                    int.TryParse(val.Value, out layoutMarginRight);
                }
                else if (name.Equals("android:layout_marginTop"))
                {
                    int.TryParse(val.Value, out layoutMarginTop);
                }
                else if (name.Equals("android:paddingLeft"))
                {
                    int.TryParse(val.Value, out paddingLeft);
                }
                else if (name.Equals("android:paddingTop"))
                {
                    int.TryParse(val.Value, out paddingTop);
                }
                else if (name.Equals("android:paddingBottom"))
                {
                    int.TryParse(val.Value, out paddingBottom);
                }
                else if (name.Equals("android:paddingRight"))
                {
                    int.TryParse(val.Value, out paddingRight);
                }
            }

            var layoutParams = new LinearLayout.LayoutParams(layoutWidth, layoutHeight);

            view.SetPadding(paddingLeft, paddingTop, paddingRight, paddingBottom);
            layoutParams.SetMargins(layoutMarginLeft, layoutMarginTop, layoutMarginRight, layoutMarginBottom);

            view.LayoutParameters = layoutParams;
            return view;
        }
    }
}