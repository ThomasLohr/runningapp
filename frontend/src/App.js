import Navbar from './Navbar.js'
import GetTime from './GetTime.js'
import GetUser from './GetUser.js'


function App() {
    return (
        <div className="App">
            <div className="content">
                <Navbar />
                <h1 className="title">Running App</h1>
                <GetTime/>
                <GetUser/>
                
            </div>
        </div>
    )
}

export default App
