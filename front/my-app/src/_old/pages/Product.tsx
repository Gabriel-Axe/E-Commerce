import { useState } from 'react';

// TODO: Make this file independent

// Product Pages
export default function ProductCreate() {
	const [form, setForm] = useState({ name: '', shop_origin_id: '', description: '', categories: '', image: '' });

	const handleSubmit = async () => {

		const payload = {
			...form,
			shop_origin_id: parseInt(form.shop_origin_id),
			categories: form.categories ? form.categories.split(',').map(c => parseInt(c.trim())) : undefined
		};

		await fetch(`http://localhost:5178/${API_BASE}/products`, {
			method: 'POST',
			headers: { 'Content-Type': 'application/json' },
			body: JSON.stringify(payload)
		});
	};

	const handlePing = async () => {
		console.log("pinging...");
		await fetch(`http://localhost:5178/api/ping`, {
			method: 'GET',
			headers: { 'Content-Type': 'application/json' }
		})
		console.log("finished ping");
	}

	return (
		<div className="p-4">
			<h2 className="text-2xl mb-4">Create Product</h2>
			<div className="space-y-3">

				<button onClick={handlePing}>Ping Backend</button>

				<input
					placeholder="Name"
					value={form.name}
					onChange={e => setForm({ ...form, name: e.target.value })}
					className="border p-2 w-full"
				/>

				<input placeholder="Shop Origin ID"
					type="number" value={form.shop_origin_id}
					onChange={e => setForm({ ...form, shop_origin_id: e.target.value })}
					className="border p-2 w-full"
				/>

				<input placeholder="Description"
					value={form.description}
					onChange={e => setForm({ ...form, description: e.target.value })}
					className="border p-2 w-full"
				/>

				<input placeholder="Categories (comma-separated IDs)"
					value={form.categories}
					onChange={e => setForm({ ...form, categories: e.target.value })}
					className="border p-2 w-full"
				/>

				<button onClick={handleSubmit} className="bg-blue-500 text-white px-4 py-2">
					Create</button>
			</div>
		</div>
	);
}
