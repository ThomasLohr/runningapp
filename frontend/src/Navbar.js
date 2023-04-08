import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faBars } from '@fortawesome/free-solid-svg-icons'

const Navbar = () => {
    return (
        <nav className="navbar">
            <span>
                <FontAwesomeIcon icon={faBars} />
            </span>
        </nav>
    )
}

export default Navbar
