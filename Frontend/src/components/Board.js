import React from 'react';
import Plant from './Plant'
import { connect } from 'react-redux';
import { fetchPlants, updatePlant } from '../actions/plantActions';

class Board extends React.Component {
   
    componentDidMount() {
      this.props.fetchPlants();
    }

    
    render() {
      return (
        <div>
          {
           this.props.plants.map((plant, i) => {
            return <Plant key={i} index={i} id={plant.id} name={plant.name} status={plant.status}
            updatePlant={this.props.updatePlant} fetchPlants={this.props.fetchPlants} imageSource={plant.imageSource}>
            </Plant>
           })
         }
        </div>
      )
    }
  }

  // Board.PropTypes = {
  //   fetchPlants: PropTypes.func.isRequired,
  //   plants: PropTypes.array.isRequired
  // }

  const mapStateToProps = state =>({
    plants: state.plants.items,
    plant: state.plants.item
  })

export default connect(mapStateToProps, {fetchPlants, updatePlant})(Board);