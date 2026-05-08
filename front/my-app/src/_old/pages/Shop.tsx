import { useState } from 'react';

// TODO: Make this file independent
const API_BASE = '/api';

// Shop Pages
export default function ShopCreate() {
	const [form, setForm] = useState({ name: '', owner_id: '', description: '', banner: '' });

	const handleSubmit = async () => {
		const payload = {
			...form,
			owner_id: parseInt(form.owner_id),
			banner: parseInt(form.banner)
		};
		await fetch(`${API_BASE}/shops`, {
			method: 'POST',
			headers: { 'Content-Type': 'application/json' },
			body: JSON.stringify(payload)
		});
	};

	return (
		<div className="p-4">
			<h2 className="text-2xl mb-4">Create Shop</h2>
			<div className="space-y-3">
				<input placeholder="Name" value={form.name} onChange={e => setForm({ ...form, name: e.target.value })} className="border p-2 w-full" />
				<input placeholder="Owner ID" type="number" value={form.owner_id} onChange={e => setForm({ ...form, owner_id: e.target.value })} className="border p-2 w-full" />
				<input placeholder="Description" value={form.description} onChange={e => setForm({ ...form, description: e.target.value })} className="border p-2 w-full" />
				<input placeholder="Banner ID" type="number" value={form.banner} onChange={e => setForm({ ...form, banner: e.target.value })} className="border p-2 w-full" />
				<button onClick={handleSubmit} className="bg-blue-500 text-white px-4 py-2">Create</button>
			</div>
		</div>
	);
}
