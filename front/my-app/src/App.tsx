import { useState } from 'react';
import ProductCreate from './pages/Product';

function App() {
	const [view, setView] = useState<'product-create' | 'home'>('home');

	return (
		<div>
			<nav>
				<button onClick={() => setView('home')}>Home</button>
				<button onClick={() => setView('product-create')}>Create Product</button>
			</nav>

			{view === 'home' && <h1>Welcome!</h1>}
			{view === 'product-create' && <ProductCreate />}
		</div>
	)
}

export default App;
