package md52af954b89e412540bc9b68f2eb771b47;


public class MvxTabActivity_1
	extends mvvmcross.droid.views.MvxTabActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Droid.Views.MvxTabActivity`1, MvvmCross.Droid, Version=5.7.0.0, Culture=neutral, PublicKeyToken=null", MvxTabActivity_1.class, __md_methods);
	}


	public MvxTabActivity_1 ()
	{
		super ();
		if (getClass () == MvxTabActivity_1.class)
			mono.android.TypeManager.Activate ("MvvmCross.Droid.Views.MvxTabActivity`1, MvvmCross.Droid, Version=5.7.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
