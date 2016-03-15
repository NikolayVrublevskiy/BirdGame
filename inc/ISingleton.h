#pragma once

template<class T>
class ISingleton
{
protected:
	ISingleton() {}
	~ISingleton() {}
	/*implicit methods exist for the copy constructor and operator= and we want to forbid calling them.*/
	ISingleton(const ISingleton &);
	ISingleton& operator =(const ISingleton &);

public:
	static T * GetInstance() {
		if (ms_pInstance == 0)
			ms_pInstance = new T;
		return ms_pInstance;
	}
	static void DestroyInstance() {
		if (ms_pInstance)
		{
			delete ms_pInstance;
			ms_pInstance = 0;
		}
	}

protected:
	static T * ms_pInstance;
};

template<typename T>
T* ISingleton<T>::ms_pInstance = 0;
