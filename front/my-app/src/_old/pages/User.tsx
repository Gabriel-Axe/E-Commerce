import { useState } from 'react';

// TODO: Make this file independent
const API_BASE = '/api';

// User Pages
export default function UserCreate() {
	const [form, setForm] = useState({ name: '', email: '', telephone: '', password: '' });

	const handleSubmit = async () => {
		await fetch(`${API_BASE}/users`, {
			method: 'POST',
			headers: { 'Content-Type': 'application/json' },
			body: JSON.stringify(form)
		});
	};

	return (
		<div className="p-4">
			<h2 className="text-2xl mb-4">Create User</h2>
			<div className="space-y-3">
				<input placeholder="Name" value={form.name} onChange={e => setForm({ ...form, name: e.target.value })} className="border p-2 w-full" />
				<input placeholder="Email" type="email" value={form.email} onChange={e => setForm({ ...form, email: e.target.value })} className="border p-2 w-full" />
				<input placeholder="Telephone" value={form.telephone} onChange={e => setForm({ ...form, telephone: e.target.value })} className="border p-2 w-full" />
				<input placeholder="Password" type="password" value={form.password} onChange={e => setForm({ ...form, password: e.target.value })} className="border p-2 w-full" />
				<button onClick={handleSubmit} className="bg-blue-500 text-white px-4 py-2">Create</button>
			</div>
		</div>
	);
}
