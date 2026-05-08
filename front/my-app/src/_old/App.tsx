import { useState } from 'react';
import ProductCreate from './pages/Product';
import ProductSearch from './pages/ProductSearch';
import UserCreate from './pages/User';
import ShopCreate from './pages/Shop';

function App() {

	const [view, setView] = useState('product-create');

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
	)
}

export default App
