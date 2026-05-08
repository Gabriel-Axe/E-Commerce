import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
// import App from './App.tsx'

createRoot(document.getElementById('root')!).render(
	<StrictMode>
		{/* <App /> */}
	</StrictMode>,
)

{/*
return (
	<div>Hello!</div>
)

	return (
		<div>
			<nav className="bg-gray-800 text-white p-4 flex gap-4">
				<button onClick={() => setView('product-create')}>Product Create</button>
				<button onClick={() => setView('product-search')}>Product Search</button>
				<button onClick={() => setView('user-create')}>User Create</button>
				<button onClick={() => setView('shop-create')}>Shop Create</button>
			</nav>
			{view === 'product-create' && <ProductCreate />}
			{view === 'product-search' && <ProductSearch />}
			{view === 'user-create' && <UserCreate />}
			{view === 'shop-create' && <ShopCreate />}
		</div>
	);
}
	*/}
