package crc643bc4a8a47d523359;


public class MyFrameRenderer
	extends crc643f46942d9dd1fff9.FrameRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("CloneMessage.Droid.Renderer.MyFrameRenderer, CloneMessage.Android", MyFrameRenderer.class, __md_methods);
	}


	public MyFrameRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MyFrameRenderer.class)
			mono.android.TypeManager.Activate ("CloneMessage.Droid.Renderer.MyFrameRenderer, CloneMessage.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MyFrameRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MyFrameRenderer.class)
			mono.android.TypeManager.Activate ("CloneMessage.Droid.Renderer.MyFrameRenderer, CloneMessage.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MyFrameRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MyFrameRenderer.class)
			mono.android.TypeManager.Activate ("CloneMessage.Droid.Renderer.MyFrameRenderer, CloneMessage.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
