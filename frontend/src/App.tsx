
import { useEffect, useState } from 'react';

function App() {
  const [friends, setFriends] = useState([]);

  useEffect(() => {
    names()
  }, []);

  const names = async () => {
    const response = await fetch('http://localhost:5183/friend');
    const data = await response.json();
    setFriends(data);
  }

  return (
    <div className="App">
      <h1>Friends</h1>
      <ul>
        {friends.map((n: { name: string, country: string, date: string, id: number, mutualFriends: number[] }, index) => (
          <li key={index}>{n.id} - {n.name}, {n.country}, {n.date} {n.mutualFriends.join(", ")}</li>
        ))}
      </ul>
    </div>
  );
}

export default App;
