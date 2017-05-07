using Android.Support.V4.View;
using Android.Content;
using Android.Util;
using Android.Views;

namespace BrainChallenge.Droid
{
	public class MyPager : ViewPager
	{
		public MyPager(Context subContext) : base(context: subContext)
		{
		}

		public MyPager(Context subContext, IAttributeSet subIAttributeSet) : base(context: subContext, attrs: subIAttributeSet)
		{
		}

		protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			int height = 0;
			for (int i = 0; i < this.ChildCount; i++)
			{
				View child = this.GetChildAt(i);
				child.Measure(widthMeasureSpec, MeasureSpec.MakeMeasureSpec(0, MeasureSpecMode.Unspecified));
				int h = child.MeasuredHeight;
				if (h > height) height = h;
			}

			heightMeasureSpec = MeasureSpec.MakeMeasureSpec(height, MeasureSpecMode.Exactly);

			base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
		}
	}
}
