import { useState } from 'react';

// TODO: Make this file independent
const API_BASE = '/api';

export default function ProductSearch() {
	const [params, setParams] = useState({ name: '', shop: '', price: '', categories: '' });
	const [results, setResults] = useState(null);

	const handleSearch = async () => {
		const query = new URLSearchParams();
		Object.entries(params).forEach(([key, val]) => val && query.append(key, val));
		const res = await fetch(`${API_BASE}/products?${query}`);
		setResults(await res.json());
	};

	return (
		<div className="p-4">
			<h2 className="text-2xl mb-4">Search Products</h2>
			<div className="space-y-2 mb-4">
				<input placeholder="Name" value={params.name} onChange={e => setParams({ ...params, name: e.target.value })} className="border p-2 w-full" />
				<input placeholder="Shop" value={params.shop} onChange={e => setParams({ ...params, shop: e.target.value })} className="border p-2 w-full" />
				<input placeholder="Price (cents)" type="number" value={params.price} onChange={e => setParams({ ...params, price: e.target.value })} className="border p-2 w-full" />
				<button onClick={handleSearch} className="bg-blue-500 text-white px-4 py-2">Search</button>
			</div>
			{results && <pre className="bg-gray-100 p-4">{JSON.stringify(results, null, 2)}</pre>}
		</div>
	);
}
